namespace Microsoft.Xna.Framework.Graphics
{
    public partial class Texture3D : Texture
    {
        
        private void PlatformConstruct(GraphicsDevice graphicsDevice, int width, int height, int depth, bool mipMap, SurfaceFormat format, bool renderTarget)
        {
        }

        private void PlatformSetData<T>(
            int level,
            int left, int top, int right, int bottom, int front, int back,
            T[] data, int startIndex, int elementCount, int width, int height, int depth)
        {
        }

        private void PlatformGetData<T>(int level, int left, int top, int right, int bottom, int front, int back, T[] data, int startIndex, int elementCount)
             where T : struct
        {
        }
    }
}