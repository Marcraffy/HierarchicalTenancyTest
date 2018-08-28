import { HierarchicalTenancyTestTemplatePage } from './app.po';

describe('HierarchicalTenancyTest App', function() {
  let page: HierarchicalTenancyTestTemplatePage;

  beforeEach(() => {
    page = new HierarchicalTenancyTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
