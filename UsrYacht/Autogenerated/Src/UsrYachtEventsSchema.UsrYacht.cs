namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5deb19d0-fa65-41a4-937f-63c6f71b00be");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8294b99-b597-4c88-ba13-f561f4418d03");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,55,244,63,220,252,100,67,208,186,215,102,43,44,33,27,133,210,142,197,29,140,210,7,69,190,56,26,178,100,36,57,89,86,242,223,119,146,210,44,78,58,182,207,47,214,221,167,239,238,59,157,230,45,186,142,11,132,10,173,229,206,44,61,155,26,189,148,77,111,185,151,70,103,207,25,16,122,39,117,3,243,173,243,216,142,143,34,199,183,218,214,232,191,229,44,178,153,246,210,75,116,255,65,97,179,53,106,191,103,62,198,232,54,134,110,37,53,160,209,22,115,177,194,150,223,81,247,240,1,242,7,103,191,115,177,242,121,249,20,175,116,253,66,73,1,66,113,231,32,102,94,209,128,43,152,112,135,175,100,162,70,242,125,164,102,214,212,172,172,17,214,70,214,112,175,231,124,77,22,10,179,248,129,194,131,67,93,163,29,65,146,155,224,146,252,68,209,143,182,113,128,229,65,237,143,110,192,130,58,96,7,173,23,17,44,199,3,86,18,133,109,112,66,126,139,116,46,19,125,72,173,81,200,150,43,232,172,20,97,54,241,14,251,140,190,218,118,88,79,141,234,91,253,141,171,30,223,239,153,215,69,24,223,151,64,207,79,202,202,37,20,73,231,26,222,93,6,148,131,252,208,74,0,178,27,55,229,90,160,194,154,138,123,219,227,56,59,99,57,111,195,227,211,230,57,222,96,133,109,167,184,15,205,106,220,192,173,17,92,201,95,124,161,112,30,121,69,178,240,224,208,210,102,106,26,54,173,37,251,138,206,244,86,16,199,88,18,25,93,156,85,9,56,108,70,90,168,124,4,249,153,190,99,113,30,55,174,50,102,34,155,116,202,75,86,153,125,253,242,159,22,168,245,20,96,159,140,109,185,47,78,172,81,89,154,31,208,0,79,71,28,224,87,214,108,162,247,217,79,129,93,176,247,34,112,194,222,101,195,191,93,182,187,200,194,247,118,15,184,187,175,102,111,2,66,236,200,234,190,191,171,68,30,24,14,129,248,252,14,90,90,90,106,135,107,120,190,220,1,167,131,54,30,184,82,102,131,53,251,13,135,46,7,235,44,4,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fe9bfdb1-8003-765e-5152-f6de5abb7fd1"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("e8294b99-b597-4c88-ba13-f561f4418d03"),
				CreatedInSchemaUId = new Guid("5deb19d0-fa65-41a4-937f-63c6f71b00be"),
				ModifiedInSchemaUId = new Guid("5deb19d0-fa65-41a4-937f-63c6f71b00be")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5deb19d0-fa65-41a4-937f-63c6f71b00be"));
		}

		#endregion

	}

	#endregion

}

