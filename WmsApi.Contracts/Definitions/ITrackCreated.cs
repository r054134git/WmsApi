using System;

namespace WmsApi
{
    public interface ITrackCreated
    {
        DateTime CreateTime { get; set; }
        string CreateUser { get; set; }
    }
}