using System;
using System.Collections.Generic;

namespace HtmlToPdfWithEF.Models
{
    public partial class Sftp
    {
        public int SqlId { get; set; }
        public Guid Id { get; set; }
        public string CrmId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CrmModifiedTime { get; set; }
        public string SftpUrl { get; set; }
        public int? SftpPort { get; set; }
        public string SftpuploadPath { get; set; }
        public string SftpdownloadPath { get; set; }
        public string SftpUser { get; set; }
        public string SftpPwd { get; set; }
        public string UploadTime { get; set; }
        public string DownloadTime { get; set; }
        public string LocaluploadPath { get; set; }
        public string LocaldownloadPath { get; set; }
        public string PrivateKeyPath { get; set; }
        public string SshHostKeyFingerprint { get; set; }
    }
}
