﻿namespace Util.Events.Handlers {
    /// <summary>
    /// 事件处理器
    /// </summary>
    public interface IEventHandler {
    }

    /// <summary>
    /// 事件处理器
    /// </summary>
    /// <typeparam name="TEvent">事件类型</typeparam>
    public interface IEventHandler<in TEvent> : IEventHandler where TEvent : IEvent {
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="event">事件</param>
        void Handle( TEvent @event ) ;
    }
}
