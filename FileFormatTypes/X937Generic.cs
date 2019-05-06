using System.ComponentModel;
using System.ComponentModel.Composition;

namespace com.shepherdchurch.ImageCashLetter.FileFormatTypes
{
    /// <summary>
    /// X9.37 Generic File Format
    /// </summary>
    [Description( "Processes a generic X9.37 export file." )]
    [Export( typeof( FileFormatTypeComponent ) )]
    [ExportMetadata( "ComponentName", "Generic X9.37 Format" )]
    public class X937Generic : X937DSTU
    {
    }
}
