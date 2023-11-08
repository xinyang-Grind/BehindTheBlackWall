// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: playerService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SEServer.Statements.Domain.Shared {
  public static partial class PlayerService
  {
    static readonly string __ServiceName = "player.PlayerService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.EnterGameResponse> __Marshaller_player_EnterGameResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.EnterGameResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.EnterRoomRequest> __Marshaller_player_EnterRoomRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.EnterRoomRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.ExitRoomResponse> __Marshaller_player_ExitRoomResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.ExitRoomResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.DeathResponse> __Marshaller_player_DeathResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.DeathResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse> __Marshaller_player_GlobalWeaponModuleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse> __Marshaller_player_RoomWeaponModuleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.GlobalRankResponse> __Marshaller_player_GlobalRankResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.GlobalRankResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.RoomRankResponse> __Marshaller_player_RoomRankResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.RoomRankResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest> __Marshaller_player_UpdateRoomWeaponModuleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest> __Marshaller_player_UpdateRoomRankRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.EnterGameResponse> __Method_EnterGame = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.EnterGameResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EnterGame",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_EnterGameResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::SEServer.Statements.Domain.Shared.EnterRoomRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_EnterRoom = new grpc::Method<global::SEServer.Statements.Domain.Shared.EnterRoomRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EnterRoom",
        __Marshaller_player_EnterRoomRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.ExitRoomResponse> __Method_ExitRoom = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.ExitRoomResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ExitRoom",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_ExitRoomResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.DeathResponse> __Method_Death = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.DeathResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Death",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_DeathResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse> __Method_CheckGlobalWeaponModule = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "CheckGlobalWeaponModule",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_GlobalWeaponModuleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse> __Method_CheckRoomWeaponModule = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "CheckRoomWeaponModule",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_RoomWeaponModuleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalRankResponse> __Method_CheckGlobalRank = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalRankResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckGlobalRank",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_GlobalRankResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomRankResponse> __Method_CheckRoomRank = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomRankResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckRoomRank",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_player_RoomRankResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateRoomWeaponModule = new grpc::Method<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UpdateRoomWeaponModule",
        __Marshaller_player_UpdateRoomWeaponModuleRequest,
        __Marshaller_google_protobuf_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateRoomRank = new grpc::Method<global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRoomRank",
        __Marshaller_player_UpdateRoomRankRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SEServer.Statements.Domain.Shared.PlayerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PlayerService</summary>
    [grpc::BindServiceMethod(typeof(PlayerService), "BindService")]
    public abstract partial class PlayerServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SEServer.Statements.Domain.Shared.EnterGameResponse> EnterGame(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> EnterRoom(global::SEServer.Statements.Domain.Shared.EnterRoomRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SEServer.Statements.Domain.Shared.ExitRoomResponse> ExitRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SEServer.Statements.Domain.Shared.DeathResponse> Death(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task CheckGlobalWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task CheckRoomWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::IServerStreamWriter<global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SEServer.Statements.Domain.Shared.GlobalRankResponse> CheckGlobalRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::SEServer.Statements.Domain.Shared.RoomRankResponse> CheckRoomRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomWeaponModule(grpc::IAsyncStreamReader<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomRank(global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PlayerService</summary>
    public partial class PlayerServiceClient : grpc::ClientBase<PlayerServiceClient>
    {
      /// <summary>Creates a new client for PlayerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlayerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PlayerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PlayerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlayerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PlayerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.EnterGameResponse EnterGame(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnterGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.EnterGameResponse EnterGame(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EnterGame, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.EnterGameResponse> EnterGameAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnterGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.EnterGameResponse> EnterGameAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EnterGame, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty EnterRoom(global::SEServer.Statements.Domain.Shared.EnterRoomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnterRoom(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty EnterRoom(global::SEServer.Statements.Domain.Shared.EnterRoomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EnterRoom, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> EnterRoomAsync(global::SEServer.Statements.Domain.Shared.EnterRoomRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnterRoomAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> EnterRoomAsync(global::SEServer.Statements.Domain.Shared.EnterRoomRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EnterRoom, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.ExitRoomResponse ExitRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExitRoom(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.ExitRoomResponse ExitRoom(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ExitRoom, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.ExitRoomResponse> ExitRoomAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExitRoomAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.ExitRoomResponse> ExitRoomAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ExitRoom, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.DeathResponse Death(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Death(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.DeathResponse Death(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Death, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.DeathResponse> DeathAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeathAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.DeathResponse> DeathAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Death, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse> CheckGlobalWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckGlobalWeaponModule(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse> CheckGlobalWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_CheckGlobalWeaponModule, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse> CheckRoomWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckRoomWeaponModule(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse> CheckRoomWeaponModule(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_CheckRoomWeaponModule, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.GlobalRankResponse CheckGlobalRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckGlobalRank(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.GlobalRankResponse CheckGlobalRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckGlobalRank, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.GlobalRankResponse> CheckGlobalRankAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckGlobalRankAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.GlobalRankResponse> CheckGlobalRankAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckGlobalRank, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.RoomRankResponse CheckRoomRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckRoomRank(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::SEServer.Statements.Domain.Shared.RoomRankResponse CheckRoomRank(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckRoomRank, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.RoomRankResponse> CheckRoomRankAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckRoomRankAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::SEServer.Statements.Domain.Shared.RoomRankResponse> CheckRoomRankAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckRoomRank, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest, global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomWeaponModule(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRoomWeaponModule(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest, global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomWeaponModule(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UpdateRoomWeaponModule, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateRoomRank(global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRoomRank(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Protobuf.WellKnownTypes.Empty UpdateRoomRank(global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRoomRank, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomRankAsync(global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRoomRankAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> UpdateRoomRankAsync(global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRoomRank, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PlayerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PlayerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PlayerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_EnterGame, serviceImpl.EnterGame)
          .AddMethod(__Method_EnterRoom, serviceImpl.EnterRoom)
          .AddMethod(__Method_ExitRoom, serviceImpl.ExitRoom)
          .AddMethod(__Method_Death, serviceImpl.Death)
          .AddMethod(__Method_CheckGlobalWeaponModule, serviceImpl.CheckGlobalWeaponModule)
          .AddMethod(__Method_CheckRoomWeaponModule, serviceImpl.CheckRoomWeaponModule)
          .AddMethod(__Method_CheckGlobalRank, serviceImpl.CheckGlobalRank)
          .AddMethod(__Method_CheckRoomRank, serviceImpl.CheckRoomRank)
          .AddMethod(__Method_UpdateRoomWeaponModule, serviceImpl.UpdateRoomWeaponModule)
          .AddMethod(__Method_UpdateRoomRank, serviceImpl.UpdateRoomRank).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PlayerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_EnterGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.EnterGameResponse>(serviceImpl.EnterGame));
      serviceBinder.AddMethod(__Method_EnterRoom, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SEServer.Statements.Domain.Shared.EnterRoomRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.EnterRoom));
      serviceBinder.AddMethod(__Method_ExitRoom, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.ExitRoomResponse>(serviceImpl.ExitRoom));
      serviceBinder.AddMethod(__Method_Death, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.DeathResponse>(serviceImpl.Death));
      serviceBinder.AddMethod(__Method_CheckGlobalWeaponModule, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalWeaponModuleResponse>(serviceImpl.CheckGlobalWeaponModule));
      serviceBinder.AddMethod(__Method_CheckRoomWeaponModule, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomWeaponModuleResponse>(serviceImpl.CheckRoomWeaponModule));
      serviceBinder.AddMethod(__Method_CheckGlobalRank, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.GlobalRankResponse>(serviceImpl.CheckGlobalRank));
      serviceBinder.AddMethod(__Method_CheckRoomRank, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::SEServer.Statements.Domain.Shared.RoomRankResponse>(serviceImpl.CheckRoomRank));
      serviceBinder.AddMethod(__Method_UpdateRoomWeaponModule, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::SEServer.Statements.Domain.Shared.UpdateRoomWeaponModuleRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateRoomWeaponModule));
      serviceBinder.AddMethod(__Method_UpdateRoomRank, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::SEServer.Statements.Domain.Shared.UpdateRoomRankRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateRoomRank));
    }

  }
}
#endregion
