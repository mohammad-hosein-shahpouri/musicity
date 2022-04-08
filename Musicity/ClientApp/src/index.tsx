import React, { Fragment, StrictMode } from "react";
import { createRoot } from "react-dom/client";
import { BrowserRouter } from "react-router-dom";
import * as serviceWorkerRegistration from "./serviceWorkerRegistration";
import { App } from "App";

const baseUrl = document
  .getElementsByTagName("base")[0]
  .getAttribute("href") as string;
const container = document.getElementById("root")!;

const root = createRoot(container);

root.render(
  <Fragment>
    <StrictMode>
      <BrowserRouter basename={baseUrl}>
        <App />
      </BrowserRouter>
    </StrictMode>
  </Fragment>
);



