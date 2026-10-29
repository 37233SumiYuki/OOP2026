namespace SelfOrderSystem.Models;

public enum OrderStatus          // 注文の状態を4種類で表す 
{
    New = 0,                    // 新規注文 
    Accepted = 1,               // 受付済み 
    Cooking = 2,                // 調理中 
    Served = 3                  // 提供済み 
}