﻿using Models.DataBases.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models.DataBases.WebCore
{


    /// <summary>
    /// 用户和支付宝绑定关系表
    /// </summary>
    [Table("t_user_bind_alipay")]
    public class TUserBindAlipay :CD
    {

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }
        public TUser User { get; set; }


        /// <summary>
        /// 关联支付宝账户
        /// </summary>
        public string AlipayKeyId { get; set; }
        public TAlipayKey AlipayKey { get; set; }



        /// <summary>
        /// 支付宝UserId
        /// </summary>
        public string AlipayUserId { get; set; }
    }
}
