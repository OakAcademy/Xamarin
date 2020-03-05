using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinPagesApp.Views
{
    public class MyMasterDetailPage2: MasterDetailPage
    {
        public MyMasterDetailPage2()
        {
            Master = new MyContentPage() { Title="Master Content Page"};
            Detail = new NavigationPage(new MyContentPage2());
        }
    }
}
