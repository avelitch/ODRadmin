﻿using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODRadmin.Models
{
  
    public class FileManager2Helper
    {
        public static FileManagerSettings GetSettings()
        {
            FileManagerSettings settings = new FileManagerSettings();
            settings.Name = "FileManager";
            settings.CallbackRouteValues = new { Controller = "TaxSafe", Action = "FileManagerPartial" };
            settings.DownloadRouteValues = new { Controller = "TaxSafe", Action = "FileManagerDownload" };

            settings.Settings.AllowedFileExtensions = new string[] { ".jpg", ".jpeg", ".gif", ".rtf", ".txt", ".avi", ".png", ".mp3", ".xml", ".xls", ".xlsx", ".xltm", ".xlsm", ".doc", ".docs", ".dotx", ".dot", ".pdf", ".eml" };
            settings.Settings.EnableMultiSelect = true;
            settings.SettingsEditing.AllowCreate = true;
            settings.SettingsEditing.AllowDelete = true;
            settings.SettingsEditing.AllowMove = true;
            settings.SettingsEditing.AllowRename = true;
            settings.SettingsEditing.AllowCopy = true;
            settings.SettingsEditing.AllowDownload = true;
           

            settings.SettingsUpload.Enabled = true;
            return settings;
        }
    }
}