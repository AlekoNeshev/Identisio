﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Skyware.Identisio.Organizations.Bg
{

    /// <summary>
    /// Identifier for branches of health institutions in Bulgaria
    /// </summary>
    public class NhifCode : IdentifierBase
    {

        public override string Name => "Nhif code";

        public override string NativeAbbreviation => "НЗОК номер";

        public override string NativeName => "НЗОК номер";

        public override bool IsPrivateData => false;

        //TODO: implement Parse

        // AABBCCCDDD
        // AA - Област, 01-28
        // НЕЩО СПЕЦИАЛНО 80-82
        // CCC - Вид ЛЗ
        // DDD - Пореден номер - 001 - 999

    }

}
