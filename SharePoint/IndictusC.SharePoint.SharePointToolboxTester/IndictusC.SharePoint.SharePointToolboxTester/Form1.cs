using System;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndictusC.SharePoint;
using Microsoft.SharePoint.Client;
using System.Diagnostics;
//using System.Web.Script.Serialization;
using Newtonsoft;

namespace IndictusC.SharePoint.SharePointToolboxTester
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				string sURL = "https://mostechdev.sharepoint.com";
				SharePointOnlineCredentials creds = SharePointToolbox.RESTMan.CreateCredentials("mos@mostechdev.onmicrosoft.com", "MagOff_991");
				HttpClient client = SharePointToolbox.RESTMan.GetClient(sURL, creds);

				//this._testJson();
				//this._testGetListItems();
				//this._testGetData();											
				this._testGetListItem(client, sURL, 1);				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		//===============================================================================================
		public class Account
		{
			public string Email { get; set; }
			public bool Active { get; set; }
			public DateTime CreatedDate { get; set; }
			public IList<string> Roles { get; set; }
		}
		
		private void _testJson()
		{
			string json = @"{'Email': 'james@example.com', 'Active': true, 'CreatedDate': '2013-01-20T00:00:00Z', 'Roles': ['User', 'Admin']}";

			try
			{				
				Account account = Newtonsoft.Json.JsonConvert.DeserializeObject<Account>(json);								
				Debug.WriteLine(account.Email);
			}
			catch (Exception ex) { throw ex; }
		}

		

		private async void _testGetListItems()
		{
			try
			{
				string sURL = "https://mostechdev.sharepoint.com";
				SharePointOnlineCredentials creds = SharePointToolbox.RESTMan.CreateCredentials("mos@mostechdev.onmicrosoft.com", "");
				HttpClient client = SharePointToolbox.RESTMan.GetClient(sURL, creds);				
				string sJson = await SharePointToolbox.RESTMan.GetListItems(client, sURL, "Test");
				//Debug.WriteLine(sJson);
				TestListRootobject tl  = Newtonsoft.Json.JsonConvert.DeserializeObject<TestListRootobject>(sJson);
				Debug.WriteLine("");
			}
			catch (Exception ex) { throw ex; }
		}


		//===============================================================================================
		private async void _testGetListItem(HttpClient client, string sURL, int iItemID)
		{
			try
			{				
				string sJson = await SharePointToolbox.RESTMan.GetListItem(client, sURL, "Test", iItemID);
				//Debug.WriteLine(sJson);
				TestItem tl = Newtonsoft.Json.JsonConvert.DeserializeObject<TestItem>(sJson);
				Debug.WriteLine("");
			}
			catch (Exception ex) { throw ex; }
		}

		private async void _testGetData()
		{
			try
			{
				string sURL = "https://mostechdev.sharepoint.com";
				SharePointOnlineCredentials creds = SharePointToolbox.RESTMan.CreateCredentials("mos@mostechdev.onmicrosoft.com", "");
				HttpClient client = SharePointToolbox.RESTMan.GetClient(sURL, creds);
				// {0}/_api/web/lists/GetByTitle('" + sListName + "')/items
				string sJson = await SharePointToolbox.RESTMan.GetData(client, sURL, "{0}/_api/web/lists/GetByTitle('Test')/items");
				TestListRootobject tl = Newtonsoft.Json.JsonConvert.DeserializeObject<TestListRootobject>(sJson);

				//Debug.WriteLine(sJson);				
				Debug.WriteLine("");
			}
			catch (Exception ex) { throw ex; }
		}



	}
}
