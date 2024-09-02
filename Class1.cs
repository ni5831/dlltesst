using System;
using Dalamud.Configuration;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using Dalamud.Plugin;
using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.IoC;
using System.Collections.Generic;

namespace dlltesst{

public class Class1 : IDalamudPlugin
{

  public string Name = "dlltesst";
  public Class1(){
    Service.commandManager.AddHandler("/dll", new(InChat) { HelpMessage = "This is a test chat!"});
  }
  public void InChat(string command, string args){
    Service.chatGui.Print("Hello from the dlltesst plugin!");
  }
  public void Dispose() {

  }
}

}
