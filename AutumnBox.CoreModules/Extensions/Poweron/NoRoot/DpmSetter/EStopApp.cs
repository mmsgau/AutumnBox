﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/29 1:30:57 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device.Management.AppFx;
using AutumnBox.CoreModules.Lib;
using AutumnBox.OpenFramework.Extension;
using System;

namespace AutumnBox.CoreModules.Extensions.Poweron.NoRoot.DpmSetter
{
    [ExtName("免ROOT激活小黑屋", "en-us:Set StopApp as DPM without root")]
    [ExtAppProperty("web1n.stopapp")]
    [ExtIcon("Icons.stopapp.png")]
    [ExtPriority(ExtPriority.HIGH)]
    [ExtRequiredDeviceStates(Basic.Device.DeviceState.Poweron)]
    internal class EStopApp : DpmSetterExtension
    {
        protected override ComponentName ReceiverName => throw new System.NotImplementedException();

        protected override int SetReciverAsDpm()
        {
            return CmdStation.Register(
                GodPower
                .GetSetStopAppCommand()
                )
                .To(OutputPrinter)
                .Execute().ExitCode;
        }
    }
}
