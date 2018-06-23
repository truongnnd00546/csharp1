using System;
using YangYesterday.controller;
using YangYesterday.entity;
using YangYesterday.model;
using YangYesterday.view;

namespace YangYesterday
{
    class Program
    {
        public static YYAccount currentLoggedInYyAccount;
        public static YYAccountController controller = new YYAccountController();


        static void Main(string[] args)
        {
          



            ApplicationView view = new ApplicationView();
           
            while (true)
            {
                if (Program.currentLoggedInYyAccount != null)
                {
                    view.GenerateCustomerMenu();
                }
                else
                {
                    view.GenerateDefaultMenu();
                }
            }
        }
    }
}