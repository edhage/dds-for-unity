﻿/* 
 Copyright 2020 Edward Hage

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System;
using DDSAPIHelper;
using builtin_interfaces.msg.dds_;

namespace ros_helper 
{
    public class RosHelper
    {
        
        public static Time_ GetUnixTimestamp()
        {
            double unixTimestamp = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            int sec = (int)unixTimestamp;
            uint nsec = (uint) ((unixTimestamp - sec) * 1e9);
            Time_ t = new Time_
            {
                sec_ = sec,
                nanosec_ = nsec
            };
            return t;
        }

    }
}

