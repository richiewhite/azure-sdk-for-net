// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Data Protection Manager (DPM) specific backup engine.
    /// </summary>
    public partial class DpmBackupEngine : BackupEngineBase
    {
        /// <summary>
        /// Initializes a new instance of the DpmBackupEngine class.
        /// </summary>
        public DpmBackupEngine() { }

        /// <summary>
        /// Initializes a new instance of the DpmBackupEngine class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the backup
        /// engine.</param>
        /// <param name="backupManagementType">Type of backup management for
        /// the backup engine. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer',
        /// 'AzureSql'</param>
        /// <param name="registrationStatus">Registration status of the backup
        /// engine with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Backup status of the backup
        /// engine.</param>
        /// <param name="canReRegister">Flag indicating if the backup engine
        /// be registered, once already registered.</param>
        /// <param name="backupEngineId">ID of the backup engine.</param>
        public DpmBackupEngine(string friendlyName = default(string), BackupManagementType? backupManagementType = default(BackupManagementType?), string registrationStatus = default(string), string healthStatus = default(string), bool? canReRegister = default(bool?), string backupEngineId = default(string))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, canReRegister, backupEngineId)
        {
        }

    }
}
