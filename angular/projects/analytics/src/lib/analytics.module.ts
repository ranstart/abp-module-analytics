import { NgModule } from '@angular/core';
import { AnalyticsComponent } from './components/analytics.component';
import { AnalyticsRoutingModule } from './analytics-routing.module';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@NgModule({
  declarations: [AnalyticsComponent],
  imports: [CoreModule, ThemeSharedModule, AnalyticsRoutingModule],
  exports: [AnalyticsComponent],
})
export class AnalyticsModule {}
