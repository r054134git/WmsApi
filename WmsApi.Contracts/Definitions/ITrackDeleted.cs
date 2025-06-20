using System;

namespace WmsApi
{
    public interface ITrackDeleted
    {
        bool IsDeleted { get; set; }
    }
}