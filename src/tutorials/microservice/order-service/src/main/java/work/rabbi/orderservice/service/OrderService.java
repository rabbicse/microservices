package work.rabbi.orderservice.service;

import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;
import org.springframework.web.reactive.function.client.WebClient;
import work.rabbi.orderservice.client.InventoryClient;
import work.rabbi.orderservice.dto.InventoryResponse;
import work.rabbi.orderservice.dto.OrderLineItemsDto;
import work.rabbi.orderservice.dto.OrderRequest;
import work.rabbi.orderservice.model.Order;
import work.rabbi.orderservice.model.OrderLineItems;
import work.rabbi.orderservice.repository.OrderRepository;

import java.util.Arrays;
import java.util.List;
import java.util.UUID;

@Service
@RequiredArgsConstructor
@Slf4j
@Transactional
public class OrderService {
    private final OrderRepository orderRepository;
    private final InventoryClient inventoryClient;
    private final WebClient.Builder webClientBuilder;

    public String placeOrder(OrderRequest orderRequest) {
        Order order = new Order();
        order.setOrderNumber(UUID.randomUUID().toString());

        List<OrderLineItems> orderLineItems = orderRequest.getOrderLineItemsDtoList().stream().map(this::mapToDto).toList();

        order.setOrderLineItemsList(orderLineItems);

        List<String> skuCodes = order.getOrderLineItemsList().stream().map(OrderLineItems::getSkuCode).toList();

        // Call Inventory Service, and place order if product is in
        // stock
        log.info("Checking inventory");
//        InventoryResponse[] inventoryResponsArray = webClientBuilder.build().get()
//                .uri("http://inventory-service/api/inventory",
//                        uriBuilder -> uriBuilder.queryParam("skuCode", skuCodes).build())
//                .retrieve()
//                .bodyToMono(InventoryResponse[].class)
//                .block();

        boolean allProductsInStock = inventoryClient.checkStock(skuCodes).stream().allMatch(InventoryResponse::isInStock);

        if (allProductsInStock) {
            orderRepository.save(order);
            return "Order Placed Successfully";
        } else {
            throw new IllegalArgumentException("Product is not in stock, please try again later");
        }
    }

    private OrderLineItems mapToDto(OrderLineItemsDto orderLineItemsDto) {
        OrderLineItems orderLineItems = new OrderLineItems();
        orderLineItems.setPrice(orderLineItemsDto.getPrice());
        orderLineItems.setQuantity(orderLineItemsDto.getQuantity());
        orderLineItems.setSkuCode(orderLineItemsDto.getSkuCode());
        return orderLineItems;
    }
}
