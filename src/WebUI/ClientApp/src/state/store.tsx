import { legacy_createStore, combineReducers, applyMiddleware } from "redux";
import { createLogger } from "redux-logger";
import thunk from "redux-thunk";

import stateLoader from "./StateLoader";

import session from "src/reducers/sessionReducer";
import loading from "src/reducers/loadingReducer";

export default legacy_createStore(
  combineReducers({
    session,
    loading,
  }),
  stateLoader.loadState(),
  applyMiddleware(
    // createLogger(),
    //comment for production
    thunk
  )
);
