namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrEncryptedDemoProcessMethodsWrapper

	/// <exclude/>
	public class UsrEncryptedDemoProcessMethodsWrapper : ProcessModel
	{

		public UsrEncryptedDemoProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			string pw = Core.Configuration.SysSettings.GetValue(UserConnection, "TopSecretMilitaryPassword", string.Empty);
			Set("MyParam", pw);
			return true;
		}

		#endregion

	}

	#endregion

}

