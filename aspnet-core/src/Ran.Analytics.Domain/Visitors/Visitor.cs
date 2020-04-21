using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Ran.Analytics.Visitors
{
    /// <summary>
    /// 访问记录
    /// </summary>
    public class Visitor:Entity<Guid>,IMultiTenant
    {
        protected Visitor() { }

        public Visitor(Guid id, string clientIpAddress, Guid? userId, DateTime onTime, string referrer, string providerName, Guid providerKey,Guid? tenantId)
        {
            this.Id = id;
            this.ClientIpAddress = clientIpAddress;
            this.UserId = userId;
            this.OnTime = onTime;
            this.Referrer = referrer;
            this.ProviderKey = providerKey;
            this.ProviderName = providerName;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// IP
        /// </summary>
        public string ClientIpAddress { get; set; }

        public Guid? UserId { get; set; }

        public DateTime OnTime { get; set; }


        /// <summary>
        /// 来路
        /// </summary>
        public string Referrer { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Guid ProviderKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ProviderName { get; set; }

        public Guid? TenantId { get; set; }
    }
}
