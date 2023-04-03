using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Reflection;

namespace AS_Coursework
{

    public static class EmbeddedResourceManager
    {

        static EmbeddedResourceManager()
        {

            // Initialize static members
            this_assembly = Assembly.GetExecutingAssembly();
            embedded_font_collection = new PrivateFontCollection();

            // Write all embedded resource paths, for debugging
            Console.WriteLine("\n**DEBUG**\nEmbeddedResourceNames:");
            foreach (string s in this_assembly.GetManifestResourceNames())
            {
                Console.WriteLine("\t" + s);
            }

        }

        public static PrivateFontCollection embedded_font_collection
        {
            get;
            private set;
        }

        private static readonly Assembly this_assembly;

        private static Stream get_resstream(string name)
        {
            return this_assembly.GetManifestResourceStream(name);
        }

        private static string get_typeext(Type t)
        {
            switch (t.Name)
            {
                case "Image":
                    return ".png"; // We only use PNGs, ".Ico" being an exception due to WF limitations
                case "Icon":
                    return ".ico"; // Needed for the program icon!
                case "FontFamily":
                    return ".ttf"; // We never use .otf, no real reason ¯\_(ツ)_/¯
                case "String":
                    return ".txt"; // Used as a test-case one time, don't know if I'll ever really use this but no effort to implement
                default:
                    return ""; // I'm not writing out that error message again
            }
        }

        private static Dictionary<string, object> cache = new Dictionary<string, object>();

        private static bool try_get_cached(string name, out object cached)
        {
            cached = null;
            bool had_key = cache.ContainsKey(name);
            if (had_key)
            {
                cached = cache[name];
            }
            return had_key;
        }

        public static T get<T>(string name)
        {

            Type t = typeof(T);
            T return_value = (dynamic)null;

            if (try_get_cached(name, out object cached))
            {
                return (T)cached;
            }

            Stream embedded_stream = get_resstream(name + get_typeext(t));
            switch (t.Name)
            {

                case "String":
                    using (StreamReader reader = new StreamReader(embedded_stream))
                    {
                        // We use "(T)(dynamic)" here to force a conversion to T
                        // This IS safe, as we've already checked the type
                        // This *can* fail if the wrong type is given to us, but garbage in, garbage out
                        return_value = (T)(dynamic)reader.ReadToEnd();
                    }
                    break;

                case "Image":
                    return_value = (T)(dynamic)Image.FromStream(embedded_stream);
                    break;

                case "Icon":
                    return_value = (T)(dynamic)new Icon(embedded_stream);
                    break;

                case "FontFamily":
                    byte[] fontdata = new byte[embedded_stream.Length];
                    embedded_stream.Read(fontdata, 0, (int)embedded_stream.Length);
                    embedded_stream.Close();
                    unsafe
                    {
                        fixed (byte* pFontData = fontdata)
                        {
                            embedded_font_collection.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                        }
                    }
                    return_value = (T)(dynamic)embedded_font_collection.Families[embedded_font_collection.Families.Length - 1];
                    break;

                case "SoundPlayer":
                    return_value = (T)(dynamic)new SoundPlayer(embedded_stream);
                    break;

                default:
                    throw new NotImplementedException("Class " + t.FullName + " not implemented for automated un-embedding!");

            }

            cache[name] = return_value;

            return return_value;

        }

    }

}