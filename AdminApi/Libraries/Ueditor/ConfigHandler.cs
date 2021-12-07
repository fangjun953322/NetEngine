﻿using Microsoft.AspNetCore.Http;


namespace AdminApi.Libraries.Ueditor
{

    /// <summary>
    /// Config 的摘要说明
    /// </summary>
    public class ConfigHandler : Handler
    {


        public override string Process()
        {
            return WriteJson(Config.Items);
        }
    }

}