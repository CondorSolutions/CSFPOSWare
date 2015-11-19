using CSFPOSWare.CompositeModels;
using CSFPOSWare.DAO;
using CSFPOSWare.Forms;
using CSFPOSWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFPOSWare
{
    public class Main
    {


        public void run(string function)
        {
            CSConfigurationDAO csConfigurationDAO = new CSConfigurationDAO();
            GlobalValues.mallSetup = csConfigurationDAO.get(CSConfiguration.Sections.General, CSConfiguration.Parameters.MallSetup).Value;
            SaleInfoUtil saleInfoUtil = new SaleInfoUtil();
            CSSale csSale = saleInfoUtil.getSaleInfo();
            function = "SETTLE";
            switch (function)
            {
                case "SETTLE":
                    //SettleCheckFormHelper settleCheckFormHelper = new SettleCheckFormHelper(csSale);
                    SettleCheckForm settleCheckForm = new SettleCheckForm(csSale);
                    settleCheckForm.ShowDialog();
                    break;
                default://Sale Info

                    break;
            }


            // saleInfoUtil.tester();
        }

        public class GlobalValues
        {
            public static string mallSetup = "";

        }
    }
}