﻿// Decompiled with JetBrains decompiler
// Type: CocoStudio.Model.ExtensionModel.ProtobufSerializer
// Assembly: CocoStudio.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9A645332-034C-44D3-9062-5E94EDCB75FF
// Assembly location: C:\Program Files (x86)\Cocos\Cocos Studio 2\CocoStudio.Model.dll

using CocoStudio.Core;
using CocoStudio.EngineAdapterWrap;
using CocoStudio.Projects;
using Mono.Addins;
using MonoDevelop.Core;

namespace CocoStudio.Model.ExtensionModel
{
  [Extension(typeof (IGameProjectSerializer))]
  internal class ProtobufSerializer : IGameProjectSerializer
  {
    private const string displayName = "Protocol Buffers�";

    public string ID
    {
      get
      {
        return "Serializer_ProtocolBuffers";
      }
    }

    public string Label
    {
      get
      {
        return "Protocol Buffers";
      }
    }

    public string Serialize(PublishInfo info, IProjectFile projFile)
    {
      FilePath destinationFilePath = (FilePath) info.DestinationFilePath;
      string sourceFilePath = info.SourceFilePath;
      string des = (string) destinationFilePath.ChangeExtension(".csb");
      string itemDirectory = (string) Services.ProjectOperations.CurrentSelectedSolution.ItemDirectory;
      return CSCocosHelp.ConvertToBinProto(des, sourceFilePath, itemDirectory);
    }
  }
}
