﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SciMaterials.DAL.Resources.Contracts.Entities;

[Table("Files")]
public class File : Resource
{
    public long Size { get; set; }
    public string? Hash { get; set; }
    public Guid? ContentTypeId { get; set; }
    public Guid? FileGroupId { get; set; }
    public int AntivirusScanStatus { get; set; }
    public DateTime? AntivirusScanDate { get; set; }
    public string ShortLink { get; set; } = string.Empty;

    public ContentType? ContentType { get; set; }
    public FileGroup? FileGroup { get; set; }
}
