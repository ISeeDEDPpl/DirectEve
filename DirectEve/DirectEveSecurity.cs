// ------------------------------------------------------------------------------
//   <copyright from='2010' to='2015' company='THEHACKERWITHIN.COM'>
//     Copyright (c) TheHackerWithin.COM. All Rights Reserved.
// 
//     Please look in the accompanying license.htm file for the license that 
//     applies to this source code. (a copy can also be found at: 
//     http://www.thehackerwithin.com/license.htm)
//   </copyright>
// -------------------------------------------------------------------------------

namespace DirectEve
{
    using System;
    using System.Reflection;
    using System.Threading;
    using Certs = Certificates.Certificates;

    internal class DirectEveSecurity
    {
        private DirectEve _directEve;

        private const string _retrieveLicenseUrl = "http://support.thehackerwithin.com/Subscription/GenerateLicense";
        private const string _licenseServer = "http://license.thehackerwithin.com/LicenseV1.svc";
        private const int _pulseInterval = 60;

        private const string _obsoleteDirectEve = "Your DirectEve version is obsolete, please download a new version from http://support.thehackerwithin.com !";
        private const string _invalidSupportLicense = "Invalid support license, please download a new support license from http://support.thehackerwithin.com !";
        private const string _verifyError = "Unable to verify your support license, please try again later !";

        //private string _email;
        //private Guid _licenseKey;
        private Version _version;
        //private Guid _instanceId;
        //private int _activeInstances;
        //private int _supportInstances;

        //private Thread _pulseThread;
        //private bool _pulseResult;
        //private DateTime _lastPulse;

        internal DirectEveSecurity(DirectEve directEve)
        {
            _directEve = directEve;
#if DEBUG
            _directEve.Log("DirectEve: Debug: Starting security");
#endif
            _version = Assembly.GetExecutingAssembly().GetName().Version;
            //_pulseResult = true;
            //_lastPulse = DateTime.Now;
        }

        internal Version Version
        {
            get { return _version; }
        }
    }
}