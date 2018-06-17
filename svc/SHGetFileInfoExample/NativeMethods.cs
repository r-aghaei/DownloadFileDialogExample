using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SHGetFileInfoExample {
    public enum SHGetFileInfoFlags : uint {
        SHGFI_ADDOVERLAYS = 0x000000020,
        SHGFI_ATTR_SPECIFIED = 0x000020000,
        SHGFI_ATTRIBUTES = 0x000000800,
        SHGFI_DISPLAYNAME = 0x000000200,
        SHGFI_EXETYPE = 0x000002000,
        SHGFI_ICON = 0x000000100,
        SHGFI_ICONLOCATION = 0x000001000,
        SHGFI_LARGEICON = 0x000000000,
        SHGFI_LINKOVERLAY = 0x000008000,
        SHGFI_OPENICON = 0x000000002,
        SHGFI_OVERLAYINDEX = 0x000000040,
        SHGFI_PIDL = 0x000000008,
        SHGFI_SELECTED = 0x000010000,
        SHGFI_SHELLICONSIZE = 0x000000004,
        SHGFI_SMALLICON = 0x000000001,
        SHGFI_SYSICONINDEX = 0x000004000,
        SHGFI_TYPENAME = 0x000000400,
        SHGFI_USEFILEATTRIBUTES = 0x000000010,
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct SHFILEINFO {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };
    public static class NativeMethods {

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            FileAttributes dwFileAttributes,
            ref SHFILEINFO psfi, uint cbFileInfo,
            SHGetFileInfoFlags uFlags);
    }
}
