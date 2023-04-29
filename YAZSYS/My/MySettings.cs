namespace YAZSYS.My
{
    using A;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [EditorBrowsable(EditorBrowsableState.Advanced), GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"), CompilerGenerated]
    public sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) SettingsBase.Synchronized(new MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (D.A.SaveMySettingsOnExit)
            {
                H.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            D.A.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }

        [DebuggerNonUserCode, SpecialSetting(SpecialSetting.ConnectionString), ApplicationScopedSetting, DefaultSettingValue(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\DB.mdf;")]
        public string DBConnectionString =>
            Conversions.ToString(this["DBConnectionString"]);
    }
}

