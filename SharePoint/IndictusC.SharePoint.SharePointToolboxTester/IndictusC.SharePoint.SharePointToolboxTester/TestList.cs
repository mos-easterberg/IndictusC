using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndictusC.SharePoint.SharePointToolboxTester
{

	public class TestListRootobject
	{
		public string odatametadata { get; set; }
		public TestListValue[] value { get; set; }
	}

	public class TestListValue
	{
		public string odatatype { get; set; }
		public string odataid { get; set; }
		public string odataetag { get; set; }
		public string odataeditLink { get; set; }
		public int FileSystemObjectType { get; set; }
		public int Id { get; set; }
		public object ServerRedirectedEmbedUri { get; set; }
		public string ServerRedirectedEmbedUrl { get; set; }
		public int ID { get; set; }
		public string ContentTypeId { get; set; }
		public string Title { get; set; }
		public DateTime Modified { get; set; }
		public DateTime Created { get; set; }
		public int AuthorId { get; set; }
		public int EditorId { get; set; }
		public string OData__UIVersionString { get; set; }
		public bool Attachments { get; set; }
		public string GUID { get; set; }
		public object ComplianceAssetId { get; set; }
	}


}



