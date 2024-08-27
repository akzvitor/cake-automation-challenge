QUnit.config.autostart = false;

sap.ui.require([
	"sap/ui/core/Core",
	"ui5/coders/test/integration/AllJourneys"
], async (Core) => {
	"use strict";

	await Core.ready();

	QUnit.start();
});