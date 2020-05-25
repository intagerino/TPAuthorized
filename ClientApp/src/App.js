import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import Employee from './components/Employee';
import Subjects from './components/Subjects';
import AddSubject from './components/AddSubject';
import Subject from './components/Subject';
import EventCalendar from './components/EventCalendar';
import Invitation from './components/Invitation';
import LearningTree from './components/LearningTree';
import Login from './components/Login';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <AuthorizeRoute path='/fetch-data' component={FetchData} />
        <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
        <Route path='/profile' component={Employee} />
        <Route path='/learningTree' component={LearningTree} />
        <Route path='/subjects' component={Subjects} />
        <Route path='/add-subject' component={AddSubject} />
        <Route path='/login' component={Login} />
        <Route path='/subject' component={Subject} />
        <Route path='/calendar' component={EventCalendar} />
        <Route path='/invite' component={Invitation} />
      </Layout>
    );
  }
}
