package work.rabbi.api.lcissuanceapi;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;
import org.zalando.jackson.datatype.money.MoneyModule;

@SpringBootApplication
public class LcIssuanceApiApplication {

    public static void main(String[] args) {
        SpringApplication.run(LcIssuanceApiApplication.class, args);
    }

    @Bean
    MoneyModule moneyModule() {
        return new MoneyModule().withAmountFieldName("value");
    }
}
