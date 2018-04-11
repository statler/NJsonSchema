using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJsonSchema.CodeGeneration.TypeScript
{
    /// <summary>
    /// Provides a list of property name substitutions in the generated models
    /// </summary>
    public static class RenamePropertyFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public static string getNewPropertyName(string ClassName, string PropertyName)
        {
            if (DctRenames.ContainsKey(ClassName) && DctRenames[ClassName].ContainsKey(PropertyName))
                return DctRenames[ClassName][PropertyName];
            if (DctRenames.ContainsKey("All") && DctRenames["All"].ContainsKey(PropertyName))
                return DctRenames["All"][PropertyName];
            else return PropertyName;
        }

        static Dictionary<string, Dictionary<string, string>> dctRenames;
        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, Dictionary<string, string>> DctRenames
        {
            get
            {
                if (dctRenames == null) populateRenames();
                return dctRenames;
            }
        }

        static void populateRenames()
        {
            dctRenames = new Dictionary<string, Dictionary<string, string>>();
            dctRenames["All"] = new Dictionary<string, string>()
            {
                {"LotItpdetailId", "LotItpDetailId"},
                {"LotItpid", "LotItpId"},
                {"Itpid", "ItpId"},
                {"Ncrid", "NcrId"},
                {"Ncrno", "NcrNo"},
                {"IsAvloverride", "IsAvlOverride"}
            };
            dctRenames["LotItpdetailViewModel"] = new Dictionary<string, string>()
            {
                {"Ncr", "NcrId"},
                {"VerifyBy", "VerifyById"},
                {"CheckedBy", "CheckedById"},
                {"ApprovedBy", "ApprovedById"},
                {"NcrNavigation", "Ncr"},
                {"VerifyByNavigation", "VerifyByUser"},
                {"CheckedByNavigation", "CheckedByUser"},
                {"ApprovedByNavigation", "ApprovedByUser"}
            };
            dctRenames["LotItpViewModel"] = new Dictionary<string, string>()
            {
                {"VerifiedBy", "VerifiedById"},
                {"CheckedBy", "CheckedById"},
                {"ApprovedBy", "ApprovedById"},
                {"VerifiedByNavigation", "VerifiedByUser"},
                {"CheckedByNavigation", "CheckedByUser"},
                {"ApprovedByNavigation", "ApprovedByUser"}
            };
            dctRenames["LotViewModel"] = new Dictionary<string, string>()
            {
                {"RaisedByNavigation", "RaisedByUser"},
                {"ConformedByNavigation", "ConformedByUser"},
                {"PrimaryTag", "PrimaryTagId"},
                {"ControlLine", "ControlLineId"},
                {"RaisedBy", "RaisedById"},
                {"ConformedBy", "ConformedById"}
            };
            dctRenames["NcrViewModel"] = new Dictionary<string, string>()
            {
                {"RaisedByNavigation", "RaisedByUser"},
                {"ApprovalByNavigation", "ApprovalByUser"},
                {"CloseOutByNavigation", "CloseOutByUser"},
                {"RaisedBy", "RaisedById"},
                {"CloseOutBy", "CloseOutById"},
                {"ApprovalBy", "ApprovalById"}
            };
            dctRenames["TestRequestViewModel"] = new Dictionary<string, string>()
            {
                {"RequestedByNavigation", "RequestedByUser"},
                {"TestRequestToNavigation", "TestRequestToUser"},
                {"ControlLine", "ControlLineId"},
                {"RequestedBy", "RequestedById"},
                {"TestRequestTo", "TestRequestToId"},
                {"Daterequired", "DateRequired"},
                {"DepthtoTest", "DepthToTest"}
            };
            dctRenames["TestCoordinateViewModel"] = new Dictionary<string, string>()
            {
                {"Trid", "TestRequestId"},
                {"Tr", "TestRequest"}
            };
            dctRenames["ApprovalViewModel"] = new Dictionary<string, string>()
            {
                {"Ncrlink", "NcrLinkId"},
                {"LotItpdetailLink", "LotItpDetailLinkId"},
                {"LotQtyLink", "LotQtyLinkId"},
                {"LotAtplink", "LotAtpLinkId"},
                {"PurchaseOrderLink", "PurchaseOrderLinkId"},
                {"PurchaseOrderAcceptanceLink", "PurchaseOrderAcceptanceLinkId"},
                {"CloseOutNcr", "CloseOutNcrId"},
                {"CloseOutBy", "CloseOutById"},
                {"ResponseBy", "ResponseById"},
                {"CloseOutByNavigation", "CloseOutByUser"},
                {"ResponseByNavigation", "ResponseByUser"}
            };
        }

    }

}
