namespace Microsoft.Xna.Framework.Graphics
{
    public partial class Texture2D : Texture
    {
        private void PlatformConstruct(int width, int height, bool mipmap, SurfaceFormat format, SurfaceType type, bool shared)
        {

        }

        private void PlatformSetData<T>(int level, T[] data, int startIndex, int elementCount) where T : struct
        {

        }

        private void PlatformSetData<T>(int level, int arraySlice, Rectangle rect, T[] data, int startIndex, int elementCount) where T : struct
        {

        }

        private void PlatformGetData<T>(int level, int arraySlice, Rectangle rect, T[] data, int startIndex, int elementCount) where T : struct
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        
        protected internal virtual Texture2DDescription GetTexture2DDescription()
        {

        }

        private void PlatformReload(Stream textureStream)
        {
            
        }
    }
}