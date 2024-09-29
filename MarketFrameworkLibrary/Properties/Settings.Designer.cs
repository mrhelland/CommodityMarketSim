﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketFrameworkLibrary.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<!DOCTYPE html>
<html>
    <head>
        <title></title>
        <style>
            BODY {
                font-family: Arial;
                font-size: 14px;
                color: black;
            }
            
            table {
                border: 2px solid black;
                border-collapse: collapse;
                width: 400px;
            }
            
            td, th {
                border: 1px solid gray;
                padding: 5px;
            }
            .odd {
                background-color: #EEEEEE;
            }
            .even {
                background-color: #FFFFFF;
            }
        
        </style>
    </head>
    <body>
        <H1>%TEAM%</H1>
        <h2>Purchase Summary</h2>
        <table>
            %TRANSACTIONS%
        </table>
        
        <h2>Closing Balance : %FUNDS%</h2>
    </body>
</html>
")]
        public string HTMLPageTemplate {
            get {
                return ((string)(this["HTMLPageTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<tr class=\"%ROWSTYLE%\">\r\n    <td>%TIME%</td>\r\n    <td>%COMMODITY%</td>\r\n    <td>%" +
            "QUANTITY%</td>\r\n    <td>%PRICE%</td>\r\n    <td>%SUCCESS%</td>\r\n</tr>")]
        public string HTMLTransactionTemplate {
            get {
                return ((string)(this["HTMLTransactionTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<tr class=\"%ROWSTYLE%\">\r\n    <td>%COMMODITY%</td>\r\n    <td>%QUANTITY%</td>\r\n    <" +
            "td>%TOTALPRICE%</td>\r\n</tr>")]
        public string HTMLCommodityTemplate {
            get {
                return ((string)(this["HTMLCommodityTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<!DOCTYPE html>
<html>
    <head>
        <title></title>
        <style>
            BODY {
                font-family: Arial;
                font-size: 14px;
                color: black;
            }
            
            table {
                border: 2px solid black;
                border-collapse: collapse;
                width: 400px;
            }
            
            td, th {
                border: 1px solid gray;
                padding: 5px;
            }
            .odd {
                background-color: #EEEEEE;
            }
            .even {
                background-color: #FFFFFF;
            }
        
        </style>
    </head>
    <body>
        <H1>Closing Prices Summary</H1>
        <table>
            %COMMODITIES%
        </table>
    </body>
</html>
")]
        public string HTMLClosingPricePageTemplate {
            get {
                return ((string)(this["HTMLClosingPricePageTemplate"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\RoboticsCommo" +
            "dityMarket.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")]
        public string RoboticsCommodityMarketConnectionString {
            get {
                return ((string)(this["RoboticsCommodityMarketConnectionString"]));
            }
        }
    }
}
