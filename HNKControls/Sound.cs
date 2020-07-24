using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HNKControls {
    class Sound {
        [DllImport("winmm.dll")]
        public static extern bool PlaySound(string szSound, IntPtr hMod, PlaySoundFlags flags);
        [Flags]
        public enum PlaySoundFlags : int {
            SND_SYNC = 0x0000,    /* play synchronously (default) */ //同步 
            SND_ASYNC = 0x0001,    /* play asynchronously */ //异步 
            SND_NODEFAULT = 0x0002,    /* silence (!default) if sound not found */
            SND_MEMORY = 0x0004,    /* pszSound points to a memory file */
            SND_LOOP = 0x0008,    /* loop the sound until next sndPlaySound */
            SND_NOSTOP = 0x0010,    /* don't stop any currently playing sound */
            SND_NOWAIT = 0x00002000, /* don't wait if the driver is busy */
            SND_ALIAS = 0x00010000, /* name is a registry alias */
            SND_ALIAS_ID = 0x00110000, /* alias is a predefined ID */
            SND_FILENAME = 0x00020000, /* name is file name */
            SND_RESOURCE = 0x00040004    /* name is resource name or atom */
        }
        public static void Play(string fileName) {
            PlaySound(fileName, IntPtr.Zero, PlaySoundFlags.SND_ASYNC);
        }
    }
}
