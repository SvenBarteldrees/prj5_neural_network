//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV
{
   public static partial class CvInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapReinhardGetIntensity(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapReinhardSetIntensity(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapReinhardGetLightAdaptation(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapReinhardSetLightAdaptation(
        IntPtr obj,  
        float val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern float cveTonemapReinhardGetColorAdaptation(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveTonemapReinhardSetColorAdaptation(
        IntPtr obj,  
        float val);
     
   }

   public partial class TonemapReinhard
   {

     /// <summary>
     /// Result intensity in [-8, 8] range. Greater intensity produces brighter results.
     /// </summary>
     public float Intensity
     {
        get { return CvInvoke.cveTonemapReinhardGetIntensity(_ptr); } 
        set { CvInvoke.cveTonemapReinhardSetIntensity(_ptr, value); }
     }
     
     /// <summary>
     /// Light adaptation in [0, 1] range. If 1 adaptation is based only on pixel value, if 0 it is global, otherwise it is a weighted mean of this two cases.
     /// </summary>
     public float LightAdaptation
     {
        get { return CvInvoke.cveTonemapReinhardGetLightAdaptation(_ptr); } 
        set { CvInvoke.cveTonemapReinhardSetLightAdaptation(_ptr, value); }
     }
     
     /// <summary>
     /// chromatic adaptation in [0, 1] range. If 1 channels are treated independently, if 0 adaptation level is the same for each channel.
     /// </summary>
     public float ColorAdaptation
     {
        get { return CvInvoke.cveTonemapReinhardGetColorAdaptation(_ptr); } 
        set { CvInvoke.cveTonemapReinhardSetColorAdaptation(_ptr, value); }
     }
     
   }
}