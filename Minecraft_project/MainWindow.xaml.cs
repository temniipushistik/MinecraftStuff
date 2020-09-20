using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Minecraft_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public String Login { get; set; }


        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mainButton_Click(object sender, RoutedEventArgs e)
        {
            if (textLogin.Text != "")
            {
                Login = textLogin.Text;
                welcome.Content = "Your name is " + Login;
               // String first = "java.exe -Xmx2G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Djava.library.path=C:/Users/Business/AppData/Roaming/.minecraft/versions/1.16.3/natives/ -cp C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/datafixerupper/4.0.26/datafixerupper-4.0.26.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/authlib/1.6.25/authlib-1.6.25.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/patchy/1.1/patchy-1.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/text2speech/1.11.3/text2speech-1.11.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/text2speech/1.11.3/text2speech-1.11.3-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/javabridge/1.0.22/javabridge-1.0.22.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/brigadier/1.0.17/brigadier-1.0.17.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/google/code/gson/gson/2.8.0/gson-2.8.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/google/guava/guava/21.0/guava-21.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/ibm/icu/icu4j/66.1/icu4j-66.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/io/netty/netty-all/4.1.25.Final/netty-all-4.1.25.Final.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-core/2.8.1/log4j-core-2.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-api/2.8.1/log4j-api-2.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-compress/1.8.1/commons-compress-1.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-lang3/3.5/commons-lang3-3.5.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpclient/4.3.3/httpclient-4.3.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpcore/4.3.2/httpcore-4.3.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-tinyfd/3.2.2/lwjgl-tinyfd-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-tinyfd/3.2.2/lwjgl-tinyfd-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-opengl/3.2.2/lwjgl-opengl-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-opengl/3.2.2/lwjgl-opengl-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-openal/3.2.2/lwjgl-openal-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-openal/3.2.2/lwjgl-openal-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl/3.2.2/lwjgl-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl/3.2.2/lwjgl-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-stb/3.2.2/lwjgl-stb-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-stb/3.2.2/lwjgl-stb-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-glfw/3.2.2/lwjgl-glfw-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-glfw/3.2.2/lwjgl-glfw-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-jemalloc/3.2.2/lwjgl-jemalloc-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-jemalloc/3.2.2/lwjgl-jemalloc-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/it/unimi/dsi/fastutil/8.2.1/fastutil-8.2.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/oshi-project/oshi-core/1.1/oshi-core-1.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/commons-codec/commons-codec/1.10/commons-codec-1.10.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/commons-logging/commons-logging/1.1.";
              //  String second = "";
                System.Diagnostics.Process.Start("cmd", "java.exe -Xmx2G -XX:+UnlockExperimentalVMOptions -XX:+UseG1GC -XX:G1NewSizePercent=20 -XX:G1ReservePercent=20 -XX:MaxGCPauseMillis=50 -XX:G1HeapRegionSize=32M -Djava.library.path=C:/Users/Business/AppData/Roaming/.minecraft/versions/1.16.3/natives/ -cp C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/datafixerupper/4.0.26/datafixerupper-4.0.26.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/authlib/1.6.25/authlib-1.6.25.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/patchy/1.1/patchy-1.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/text2speech/1.11.3/text2speech-1.11.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/text2speech/1.11.3/text2speech-1.11.3-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/javabridge/1.0.22/javabridge-1.0.22.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/mojang/brigadier/1.0.17/brigadier-1.0.17.jar;C:/UsersBusiness/AppData/Roaming/.minecraft/libraries/com/google/code/gson/gson/2.8.0/gson-2.8.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/google/guava/guava/21.0/guava-21.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/com/ibm/icu/icu4j/66.1/icu4j-66.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/io/netty/netty-all/4.1.25.Final/netty-all-4.1.25.Final.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-core/2.8.1/log4j-core-2.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/logging/log4j/log4j-api/2.8.1/log4j-api-2.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-compress/1.8.1/commons-compress-1.8.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/commons/commons-lang3/3.5/commons-lang3-3.5.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpclient/4.3.3/httpclient-4.3.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/apache/httpcomponents/httpcore/4.3.2/httpcore-4.3.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-tinyfd/3.2.2/lwjgl-tinyfd-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-tinyfd/3.2.2/lwjgl-tinyfd-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-opengl/3.2.2/lwjgl-opengl-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-opengl/3.2.2/lwjgl-opengl-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-openal/3.2.2/lwjgl-openal-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-openal/3.2.2/lwjgl-openal-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl/3.2.2/lwjgl-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl/3.2.2/lwjgl-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-stb/3.2.2/lwjgl-stb-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-stb/3.2.2/lwjgl-stb-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-glfw/3.2.2/lwjgl-glfw-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-glfw/3.2.2/lwjgl-glfw-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-jemalloc/3.2.2/lwjgl-jemalloc-3.2.2-natives-windows.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/org/lwjgl/lwjgl-jemalloc/3.2.2/lwjgl-jemalloc-3.2.2.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/it/unimi/dsi/fastutil/8.2.1/fastutil-8.2.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/oshi-project/oshi-core/1.1/oshi-core-1.1.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/commons-codec/commons-codec/1.10/commons-codec-1.10.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/commons-logging/commons-logging/1.1.3/commons-logging-1.1.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/net/java/dev/jna/platform/3.4.0/platform-3.4.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/net/java/dev/jna/jna/4.4.0/jna-4.4.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/net/java/jutils/jutils/1.0.0/jutils-1.0.0.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/net/java/jinput/jinput/2.0.5/jinput-2.0.5.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/net/sf/jopt-simple/jopt-simple/5.0.3/jopt-simple-5.0.3.jar;C:/Users/Business/AppData/Roaming/.minecraft/libraries/commons-io/commons-io/2.5/commons-io-2.5.jar;C:/Users/Business/AppData/Roaming/.minecraft/versions/1.16.3/1.16.3.jar net.minecraft.client.main.Main --username " + Login + " --version 1.16.3 --accessToken 0 --userProperties {} --gameDir C:/Users/Business/AppData/Roaming/.minecraft --assetsDir C:/Users/Business/AppData/Roaming/.minecraft/assets --assetIndex 1.16 --width 800 --height 640");

            }
            else
                welcome.Content = "The required field /r/n is empty";
        }
    }
}
