package work.rabbi.fraud;

import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("api/v1/fraud-check")
public class FraudController {
    private final FraudCheckService fraudCheckService;

    public FraudController(FraudCheckService fraudCheckService) {
        this.fraudCheckService = fraudCheckService;
    }

    @GetMapping(path = "{customerId}")
    public FraudCheckResponse isFraudster(@PathVariable("customerId") Integer customerid) {
        boolean isFraudulentCustomer = fraudCheckService.isFraudulentCustomer(customerid);

        return new FraudCheckResponse(isFraudulentCustomer);
    }
}
