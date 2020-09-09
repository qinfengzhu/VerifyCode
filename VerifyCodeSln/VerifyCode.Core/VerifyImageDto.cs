using System;

namespace VerifyCode.Core
{
    /// <summary>
    /// 返回验证码
    /// </summary>
    public class VerifyImageDto
    {
        public string vtoken { get; set; }
        public int errcode { get; set; }
        public int y { get; set; }
        public string array { get; set; }
        public int imgx { get; set; }
        public int imgy { get; set; }
        public string small { get; set; }
        public string normal { get; set; }
    }

    /// <summary>
    /// 缓存标记
    /// </summary>
    public class VerifyImageRecordDto
    {
        public int code { get; set; }
        public int code_errornum { get; set; }
        public bool isValidated { get; set; }
    }
    /// <summary>
    /// 校验参数
    /// </summary>
    public class VerifyImageParametersDto
    {
        public string point { get; set; }
        public string datelist { get; set; }
        public string timespan { get; set; }
        public string vtoken { get; set; }
    }
    /// <summary>
    /// 校验结果Dto
    /// </summary>
    public class VerifyImageCheckDto
    {
        public int state { get; set; }
        public string msg { get; set; }
        public int data { get; set; }
        public string info { get; set; }
    }
    /// <summary>
    /// 图片规格
    /// </summary>
    public enum GuiGe
    {
        S300_300,
        S300_200,
        S200_100
    }
    /// <summary>
    /// 参数规格
    /// </summary>
    public class SpecDto
    {
        public string spec { get; set; }
    }
}
