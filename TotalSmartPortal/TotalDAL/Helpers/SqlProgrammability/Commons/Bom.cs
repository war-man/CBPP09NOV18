﻿using System;
using System.Text;

using TotalBase;
using TotalBase.Enums;
using TotalModel.Models;

namespace TotalDAL.Helpers.SqlProgrammability.Commons
{
    public class Bom
    {
        private readonly TotalSmartPortalEntities totalSmartPortalEntities;

        public Bom(TotalSmartPortalEntities totalSmartPortalEntities)
        {
            this.totalSmartPortalEntities = totalSmartPortalEntities;
        }

        public void RestoreProcedure()
        {
            this.GetBomIndexes();

            this.GetBomViewDetails();
            this.BomSaveRelative();
            this.BomPostSaveValidate();

            this.BomEditable();
            this.BomDeletable();




            this.GetCommodityBoms();

            this.AddCommodityBom();
            this.RemoveCommodityBom();

            this.UpdateCommodityBom();

            this.GetBomBases();
        }

        #region BOM

        private void GetBomIndexes()
        {
            string queryString;

            queryString = " @AspUserID nvarchar(128), @FromDate DateTime, @ToDate DateTime " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";

            queryString = queryString + "       SELECT      Boms.BomID, CAST(Boms.EntryDate AS DATE) AS EntryDate, Boms.Reference, Boms.Code, Boms.Name, Commodities.Code AS CommodityCode, Commodities.Name AS CommodityName, Customers.Name AS CustomerName, Boms.EffectiveDate, Materials.Code AS MaterialCode, Materials.Name AS MaterialName, BomDetails.BlockUnit, BomDetails.BlockQuantity " + "\r\n";
            queryString = queryString + "       FROM        Boms " + "\r\n";
            queryString = queryString + "                   INNER JOIN Commodities ON Boms.CommodityID = Commodities.CommodityID " + "\r\n";
            queryString = queryString + "                   INNER JOIN Customers ON Boms.CustomerID = Customers.CustomerID " + "\r\n";
            queryString = queryString + "                   LEFT  JOIN BomDetails ON Boms.BomID = BomDetails.BomID " + "\r\n";
            queryString = queryString + "                   LEFT  JOIN Commodities Materials ON BomDetails.MaterialID = Materials.CommodityID " + "\r\n";            
            queryString = queryString + "       WHERE      (SELECT TOP 1 OrganizationalUnitID FROM AccessControls INNER JOIN AspNetUsers ON AccessControls.UserID = AspNetUsers.UserID WHERE AspNetUsers.Id = @AspUserID AND AccessControls.NMVNTaskID = " + (int)TotalBase.Enums.GlobalEnums.NmvnTaskID.Bom + " AND AccessControls.AccessLevel > 0) > 0 " + "\r\n";

            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("GetBomIndexes", queryString);
        }


        private void GetBomViewDetails()
        {
            string queryString;

            queryString = " @BomID Int " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";

            queryString = queryString + "       SELECT      BomDetails.BomDetailID, BomDetails.BomID, Commodities.CommodityID, Commodities.Code AS CommodityCode, Commodities.Name AS CommodityName, Commodities.CommodityTypeID, BomDetails.BlockQuantity AS Quantity, BomDetails.BlockQuantity, BomDetails.LayerCode, BomDetails.BlockUnit, BomDetails.Remarks " + "\r\n";
            queryString = queryString + "       FROM        BomDetails " + "\r\n";
            queryString = queryString + "                   INNER JOIN Commodities ON BomDetails.BomID = @BomID AND BomDetails.MaterialID = Commodities.CommodityID " + "\r\n";
            queryString = queryString + "       ORDER BY    BomDetails.LayerCode, BomDetails.BomDetailID " + "\r\n";

            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("GetBomViewDetails", queryString);
        }

        private void BomSaveRelative()
        {
            string queryString = " @EntityID int, @SaveRelativeOption int " + "\r\n"; //SaveRelativeOption: 1: Update, -1:Undo
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("BomSaveRelative", queryString);
        }

        private void BomPostSaveValidate()
        {
            string[] queryArray = new string[0];

            //queryArray[0] = " SELECT TOP 1 @FoundEntity = 'TEST Date: ' + CAST(EntryDate AS nvarchar) FROM Boms WHERE BomID = @EntityID "; //FOR TEST TO BREAK OUT WHEN SAVE -> CHECK ROLL BACK OF TRANSACTION
            //queryArray[0] = " SELECT TOP 1 @FoundEntity = 'Service Date: ' + CAST(ServiceInvoices.EntryDate AS nvarchar) FROM Boms INNER JOIN Boms AS ServiceInvoices ON Boms.BomID = @EntityID AND Boms.ServiceInvoiceID = ServiceInvoices.BomID AND Boms.EntryDate < ServiceInvoices.EntryDate ";

            this.totalSmartPortalEntities.CreateProcedureToCheckExisting("BomPostSaveValidate", queryArray);
        }


        private void BomEditable()
        {
            string[] queryArray = new string[0];

            this.totalSmartPortalEntities.CreateProcedureToCheckExisting("BomEditable", queryArray);
        }

        private void BomDeletable()
        {
            string[] queryArray = new string[1];

            queryArray[0] = " SELECT TOP 1 @FoundEntity = BomID FROM Boms WHERE BomID = @EntityID ";

            this.totalSmartPortalEntities.CreateProcedureToCheckExisting("BomDeletable", queryArray);
        }

        #endregion BOM





        private void GetCommodityBoms()
        {
            string queryString;

            queryString = " @CommodityID int " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";

            queryString = queryString + "       SELECT      CommodityBoms.CommodityBomID, CommodityBoms.BomID, Boms.Code AS BomCode, Boms.Name AS BomName, CommodityBoms.EntryDate, CommodityBoms.Remarks, CommodityBoms.BlockUnit, CommodityBoms.BlockQuantity, CommodityBoms.IsDefault, CommodityBoms.InActive " + "\r\n";
            queryString = queryString + "       FROM        CommodityBoms INNER JOIN Boms ON CommodityBoms.CommodityID = @CommodityID AND CommodityBoms.BomID = Boms.BomID " + "\r\n";
            queryString = queryString + "       ORDER BY    CommodityBoms.EntryDate, CommodityBoms.CommodityBomID " + "\r\n";

            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("GetCommodityBoms", queryString);
        }



        private void AddCommodityBom()
        {
            string queryString;

            queryString = " @CommodityID int, @BomID int " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";
            queryString = queryString + "       DECLARE         @COUNTCommodityBomID int = (SELECT COUNT(CommodityBomID) FROM CommodityBoms WHERE CommodityID = @CommodityID) " + "\r\n";

            queryString = queryString + "       INSERT INTO     CommodityBoms   (CommodityID, BomID, EntryDate, BlockUnit, BlockQuantity, Remarks, IsDefault, InActive) " + "\r\n";
            queryString = queryString + "       VALUES                          (@CommodityID, @BomID, GETDATE(), 100, 1, NULL, IIF(@COUNTCommodityBomID = 0, 1, 0), 0) " + "\r\n";
            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("AddCommodityBom", queryString);
        }

        private void RemoveCommodityBom()
        {
            string queryString;

            queryString = " @CommodityBomID int " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";
            queryString = queryString + "       DECLARE         @CommodityID int, @MINCommodityBomID int, @COUNTCommodityBomID int, @IsDefault bit " + "\r\n";
            queryString = queryString + "       SELECT          @CommodityID = CommodityID, @IsDefault = IsDefault FROM CommodityBoms WHERE CommodityBomID = @CommodityBomID " + "\r\n";

            queryString = queryString + "       DELETE FROM     CommodityBoms WHERE CommodityBomID = @CommodityBomID" + "\r\n";

            queryString = queryString + "       SELECT          @MINCommodityBomID = MIN(CommodityBomID), @COUNTCommodityBomID = COUNT(CommodityBomID) FROM CommodityBoms WHERE CommodityID = @CommodityID " + "\r\n";
            queryString = queryString + "       IF (@IsDefault = 1 OR @COUNTCommodityBomID = 1) UPDATE CommodityBoms SET IsDefault = 1 WHERE CommodityBomID = @MINCommodityBomID" + "\r\n";
            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("RemoveCommodityBom", queryString);

        }

        private void UpdateCommodityBom()
        {
            string queryString = " @CommodityBomID int, @CommodityID int, @BlockUnit decimal(18, 2), @BlockQuantity decimal(18, 2), @Remarks nvarchar(50), @IsDefault bit " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";

            queryString = queryString + "       BEGIN " + "\r\n";

            queryString = queryString + "           UPDATE          CommodityBoms " + "\r\n";
            queryString = queryString + "           SET             BlockUnit = ROUND(IIF(@BlockUnit > 0, @BlockUnit, BlockUnit), " + (int)GlobalEnums.rndN0 + "), BlockQuantity = ROUND(IIF(@BlockQuantity > 0, @BlockQuantity, BlockQuantity), " + (int)GlobalEnums.rndQuantity + "), Remarks = @Remarks " + "\r\n";
            queryString = queryString + "           WHERE           CommodityBomID = @CommodityBomID " + "\r\n";

            queryString = queryString + "           IF (@IsDefault = 1) " + "\r\n"; //ONLY CHANGE WHEN @IsDefault = true: THIS WILL KEEP AT LEAST 1 ROW IS DEFAULT
            queryString = queryString + "               UPDATE      CommodityBoms " + "\r\n";
            queryString = queryString + "               SET         IsDefault = IIF(CommodityBomID = @CommodityBomID, 1, 0) " + "\r\n"; //IIF(CommodityBomID = @CommodityBomID, @IsDefault, 0)
            queryString = queryString + "               WHERE       CommodityID = @CommodityID " + "\r\n";

            queryString = queryString + "       END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("UpdateCommodityBom", queryString);
        }

        private void GetBomBases()
        {
            string queryString;

            string querySELECT = "              SELECT      Boms.BomID, Boms.Code, Boms.Name, Boms.Reference " + " \r\n";
            string queryFROM = "                FROM        Boms " + "\r\n";
            string queryWHERE = "               WHERE       Boms.InActive = 0 AND (@SearchText = '' OR Boms.Code LIKE '%' + @SearchText + '%' OR Boms.OfficialCode LIKE '%' + @SearchText + '%' OR Boms.Name LIKE '%' + @SearchText + '%' OR Boms.Reference LIKE '%' + @SearchText + '%') " + "\r\n";

            queryString = " @SearchText nvarchar(60), @CommodityID int, @CommodityCategoryID int, @CommodityClassID int, @CommodityLineID int " + "\r\n";
            queryString = queryString + " WITH ENCRYPTION " + "\r\n";
            queryString = queryString + " AS " + "\r\n";
            queryString = queryString + "    BEGIN " + "\r\n";

            queryString = queryString + "       IF (@CommodityID > 0) " + "\r\n"; //GET ALL BOMS BY @CommodityID
            queryString = queryString + "           " + querySELECT + ", CommodityBoms.BlockUnit, CommodityBoms.BlockQuantity " + "\r\n";
            queryString = queryString + "           " + queryFROM + " INNER JOIN CommodityBoms ON CommodityBoms.CommodityID = @CommodityID AND Boms.BomID = CommodityBoms.BomID " + "\r\n";
            queryString = queryString + "           " + queryWHERE + "\r\n";
            queryString = queryString + "       ELSE " + "\r\n"; //GET ALL BOMS BY @CommodityCategoryID AND @CommodityClassID AND @CommodityLineID
            queryString = queryString + "           " + querySELECT + ", 0.0 AS BlockUnit, 0.0 AS BlockQuantity " + "\r\n";
            queryString = queryString + "           " + queryFROM + "\r\n";
            queryString = queryString + "           " + queryWHERE + " AND CommodityLineID = @CommodityLineID " + "\r\n"; //AND CommodityCategoryID = @CommodityCategoryID AND CommodityClassID = @CommodityClassID 
            queryString = queryString + "    END " + "\r\n";

            this.totalSmartPortalEntities.CreateStoredProcedure("GetBomBases", queryString);
        }
    }
}
