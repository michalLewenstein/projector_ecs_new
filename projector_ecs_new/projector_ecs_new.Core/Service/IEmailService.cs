﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Core.Service
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
