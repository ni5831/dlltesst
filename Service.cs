using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using System.Collections.Generic;


namespace dlltesst{
  internal class Service{
    public static IDalamudPluginInterface pluginInterface = null!;
    //public static Configuration pluginConfig = null!;

    [PluginService]
    public static ICommandManager commandManager { get; private set; } = null!;

     [PluginService]
     public static IChatGui chatGui { get; private set; } = null!;
  }
}
