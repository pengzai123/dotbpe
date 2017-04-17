﻿namespace DotBPE.Rpc.Codes
{
    public interface IMessageCodecs<TMessage> where TMessage : IMessage
    {
        void Encode(TMessage message, IBufferWriter writer);
        TMessage Decode(IBufferReader reader);
        MessageMeta GetMessageMeta();
        TMessage HeartbeatMessage();
    }

    public interface IMessage
    {
        int Length{ get; }
    }

    public class MessageMeta
    {
        /// <summary>
        /// 最大包长度
        /// </summary>
        public int MaxFrameLength { get; set; }

        /// <summary>
        /// 包长在直接中的偏移位置
        /// </summary>
        public int LengthFieldOffset { get; set; }

        /// <summary>
        /// 包长本身的长度
        /// </summary>
        public int LengthFieldLength { get; set; }

        /// <summary>
        /// 包长的纠正偏移量
        /// </summary>
        public int LengthAdjustment { get; set; }

        /// <summary>
        /// 跳过的字节数
        /// </summary>
        public int InitialBytesToStrip { get; set; }

        /// <summary>
        /// 心跳间隔时间，单位毫秒
        /// </summary>
        /// <returns></returns>
        public int PingInterval{get;set;}
    }
}
