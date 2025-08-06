namespace Terrasoft.Core.Process.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: UsrGetEncryptedSysSettingTextUserTask

	[DesignModeProperty(Name = "EncryptedSysSettingCode", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e43c8b4fec474fc1aab2c2b500f1b3d0", CaptionResourceItem = "Parameters.EncryptedSysSettingCode.Caption", DescriptionResourceItem = "Parameters.EncryptedSysSettingCode.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ResultText", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "e43c8b4fec474fc1aab2c2b500f1b3d0", CaptionResourceItem = "Parameters.ResultText.Caption", DescriptionResourceItem = "Parameters.ResultText.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class UsrGetEncryptedSysSettingTextUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public UsrGetEncryptedSysSettingTextUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("e43c8b4f-ec47-4fc1-aab2-c2b500f1b3d0");
		}

		#endregion

		#region Properties: Public

		public virtual string EncryptedSysSettingCode {
			get;
			set;
		}

		public virtual string ResultText {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("EncryptedSysSettingCode")) {
				writer.WriteValue("EncryptedSysSettingCode", EncryptedSysSettingCode, null);
			}
			if (!HasMapping("ResultText")) {
				writer.WriteValue("ResultText", ResultText, null);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "EncryptedSysSettingCode":
					EncryptedSysSettingCode = reader.GetStringValue();
				break;
				case "ResultText":
					ResultText = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

