package work.rabbi.api.lcissuanceapi.domain;

import org.axonframework.test.aggregate.AggregateTestFixture;
import org.axonframework.test.aggregate.FixtureConfiguration;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import work.rabbi.api.lcissuanceapi.domain.commands.ChangeAdvisingBankCommand;
import work.rabbi.api.lcissuanceapi.domain.commands.CreateLCApplicationCommand;
import work.rabbi.api.lcissuanceapi.domain.commands.SubmitLCApplicationCommand;
import work.rabbi.api.lcissuanceapi.domain.events.AdvisingBankChangedEvent;
import work.rabbi.api.lcissuanceapi.domain.events.LCApplicationCreatedEvent;
import work.rabbi.api.lcissuanceapi.domain.events.LCApplicationSubmittedEvent;

import static org.axonframework.test.matchers.Matchers.andNoMore;
import static org.axonframework.test.matchers.Matchers.exactSequenceOf;
import static org.axonframework.test.matchers.Matchers.messageWithPayload;
import static org.hamcrest.Matchers.any;

public class LCApplicationAggregateTests {

    private FixtureConfiguration<LCApplication> fixture;

    @BeforeEach
    void setUp() {
        fixture = new AggregateTestFixture<>(LCApplication.class);
    }

    @Test
    void shouldPublishLCApplicationCreated() {
        fixture.given()

                .when(new CreateLCApplicationCommand())

                .expectEventsMatching(exactSequenceOf(
                        messageWithPayload(any(LCApplicationCreatedEvent.class)),
                        andNoMore()
                ));
    }

    @Test
    void shouldNotAllowSubmitOnAnAlreadySubmittedLC() {
        final LCApplicationId applicationId = LCApplicationId.randomId();

        fixture.given(
                        new LCApplicationCreatedEvent(applicationId),
                        new LCApplicationSubmittedEvent(applicationId))

                .when(new SubmitLCApplicationCommand(applicationId))

                .expectException(AlreadySubmittedException.class)
                .expectNoEvents();
    }

    @Test
    void shouldAllowSubmitOnlyInDraftState() {
        final LCApplicationId applicationId = LCApplicationId.randomId();

        fixture.given(new LCApplicationCreatedEvent(applicationId))
                .when(new SubmitLCApplicationCommand(applicationId))
                .expectEvents(new LCApplicationSubmittedEvent(applicationId));
    }

    @Test
    void shouldAllowChangingAdvisingBank() {
        final LCApplicationId applicationId = LCApplicationId.randomId();

        final AdvisingBank oldAdvisingBank = AdvisingBank.builder()
                .id(BankId.randomId())
                .country(Country.SOKOVIA).build();
        final AdvisingBank newAdvisingBank = AdvisingBank.builder()
                .id(BankId.randomId())
                .country(Country.WAKANDA).build();

        fixture.given(new LCApplicationCreatedEvent(applicationId, oldAdvisingBank))
                .when(new ChangeAdvisingBankCommand(applicationId, newAdvisingBank))
                .expectEvents(new AdvisingBankChangedEvent(applicationId, newAdvisingBank));
    }
}
