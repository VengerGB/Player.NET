//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DJPad.Core.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IAlbum
    {
        int Id { get; set; }

        byte[] ImageBytes { get; set; }

        string Name { get; set; }
        
        IEnumerable<IMediaItem> MediaItems { get; set; }
    }
}
