﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace StrawberryShake.Tools.SchemaRegistry
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IPublishSchemaPayload
    {
        ISchemaPublishReport Report { get; }

        string? ClientMutationId { get; }
    }
}
