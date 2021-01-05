#define WIN_32

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
#if WIN_32
using System;
using System.Windows.Forms;
using SharpVk.Khronos;

#else
using SharpVk.Glfw;

#endif

namespace vulcan_01
{
}
