package work.rabbi.controllers;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class StockController {
    @GetMapping("/stocks")
    public String[] getStocks() {
        return new String[]{"Article 1", "Article 2", "Article 3"};
    }
}
