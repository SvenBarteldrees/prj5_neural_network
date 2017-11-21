//----------------------------------------------------------------------------
//  This file is automatically generated, do not modify.      
//----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace Emgu.CV.Cuda
{
   public static partial class CudaInvoke
   {

     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     [return: MarshalAs(CvInvoke.BoolMarshalType)]
     internal static extern bool cveCudaHOGGetGammaCorrection(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetGammaCorrection(
        IntPtr obj, 
        [MarshalAs(CvInvoke.BoolMarshalType)] 
        bool val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern double cveCudaHOGGetWinSigma(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetWinSigma(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveCudaHOGGetNumLevels(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetNumLevels(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern int cveCudaHOGGetGroupThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetGroupThreshold(
        IntPtr obj,  
        int val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern double cveCudaHOGGetHitThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetHitThreshold(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern double cveCudaHOGGetScaleFactor(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetScaleFactor(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern double cveCudaHOGGetL2HysThreshold(IntPtr obj);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetL2HysThreshold(
        IntPtr obj,  
        double val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern CudaHOG.DescrFormat cveCudaHOGGetDescriptorFormat(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveCudaHOGGetDescriptorSize(IntPtr obj);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGGetWinStride(IntPtr obj, ref System.Drawing.Size val);
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
     internal static extern void cveCudaHOGSetWinStride(IntPtr obj, ref System.Drawing.Size val);
     
     [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)] 
     internal static extern IntPtr cveCudaHOGGetBlockHistogramSize(IntPtr obj);
     
   }

   public partial class CudaHOG
   {

     /// <summary>
     /// Flag to specify whether the gamma correction preprocessing is required or not
     /// </summary>
     public bool GammaCorrection
     {
        get { return CudaInvoke.cveCudaHOGGetGammaCorrection(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetGammaCorrection(_ptr, value); }
     }
     
     /// <summary>
     /// Gaussian smoothing window parameter
     /// </summary>
     public double WinSigma
     {
        get { return CudaInvoke.cveCudaHOGGetWinSigma(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetWinSigma(_ptr, value); }
     }
     
     /// <summary>
     /// Maximum number of detection window increases
     /// </summary>
     public int NumLevels
     {
        get { return CudaInvoke.cveCudaHOGGetNumLevels(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetNumLevels(_ptr, value); }
     }
     
     /// <summary>
     /// Coefficient to regulate the similarity threshold. When detected, some objects can be covered by many rectangles. 0 means not to perform grouping. See groupRectangles.
     /// </summary>
     public int GroupThreshold
     {
        get { return CudaInvoke.cveCudaHOGGetGroupThreshold(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetGroupThreshold(_ptr, value); }
     }
     
     /// <summary>
     /// Threshold for the distance between features and SVM classifying plane. Usually it is 0 and should be specfied in the detector coefficients (as the last free coefficient). But if the free coefficient is omitted (which is allowed), you can specify it manually here.
     /// </summary>
     public double HitThreshold
     {
        get { return CudaInvoke.cveCudaHOGGetHitThreshold(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetHitThreshold(_ptr, value); }
     }
     
     /// <summary>
     /// Coefficient of the detection window increase.
     /// </summary>
     public double ScaleFactor
     {
        get { return CudaInvoke.cveCudaHOGGetScaleFactor(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetScaleFactor(_ptr, value); }
     }
     
     /// <summary>
     /// L2-Hys normalization method shrinkage.
     /// </summary>
     public double L2HysThreshold
     {
        get { return CudaInvoke.cveCudaHOGGetL2HysThreshold(_ptr); } 
        set { CudaInvoke.cveCudaHOGSetL2HysThreshold(_ptr, value); }
     }
     
     /// <summary>
    /// The descriptor format
     /// </summary>
     public CudaHOG.DescrFormat DescriptorFormat
     {
        get { return CudaInvoke.cveCudaHOGGetDescriptorFormat(_ptr); } 
     }
     
     /// <summary>
    /// Returns the number of coefficients required for the classification.
     /// </summary>
     public IntPtr DescriptorSize
     {
        get { return CudaInvoke.cveCudaHOGGetDescriptorSize(_ptr); } 
     }
     
     /// <summary>
     /// Window stride. It must be a multiple of block stride.
     /// </summary>
     public System.Drawing.Size WinStride
     {
        get { System.Drawing.Size v = new System.Drawing.Size(); CudaInvoke.cveCudaHOGGetWinStride(_ptr, ref v); return v; } 
        set { CudaInvoke.cveCudaHOGSetWinStride(_ptr, ref value); }
     }
     
     /// <summary>
    /// Returns the block histogram size.
     /// </summary>
     public IntPtr BlockHistogramSize
     {
        get { return CudaInvoke.cveCudaHOGGetBlockHistogramSize(_ptr); } 
     }
     
   }
}