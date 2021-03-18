 using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcCache.Extensions;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcCache
{
    public class GrpcGoodsInformationCacheService : GrpcGoodsInformationCache.GrpcGoodsInformationCacheBase
    {
        private readonly ILogger<GrpcGoodsInformationCacheService> _logger;
        private readonly IDistributedCache _cache;
        public GrpcGoodsInformationCacheService(ILogger<GrpcGoodsInformationCacheService> logger, IDistributedCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            try
            {
                return Task.FromResult(new HelloReply
                {
                    Message = "Hello " + request.Name
                });
            }
            catch (Exception ex)
            {
                return Task.FromResult(new HelloReply
                {
                    Message = "Hello " + ex.Message
                });
            }
        }
        public override async Task<Empty> AddGoodsInformation(GrpcCacheGoodsInformation goodsInformation, ServerCallContext context)
        {
            await _cache.AddGoodsInformationAsync(goodsInformation.Key, goodsInformation);
            return new Empty();
        }
        public override async Task<GrpcCacheGoodsInformation> GetGoodsInformation(Key key, ServerCallContext context)
        {
            var result = await _cache.GetGoodsInformationAsync(key);
            if (result == null)
            {
                return new GrpcCacheGoodsInformation();
            }
            return result;
        }
    }
}
