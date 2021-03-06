﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paho.MqttDotnet
{
    /// <summary>
    /// 表示mqt断开选项
    /// </summary>
    unsafe class MqttDisconnecOptions : MqttOptions<MQTTAsync_disconnectOptions>
    {
        /// <summary>
        /// 执行成功
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="successData">数据</param>
        protected override void MQTTAsync_onSuccess(IntPtr context, void* successData)
        {
            base.RaiseOnCompleted(context, true);
        }

        /// <summary>
        /// 执行失败
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="successData">数据</param>
        protected override void MQTTAsync_onFailure(IntPtr context, MQTTAsync_failureData* failureData)
        {
            base.RaiseOnCompleted(context, false);
        }
    }
}
