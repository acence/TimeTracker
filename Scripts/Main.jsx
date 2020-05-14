import React from 'react';
import ReactDOM from 'react-dom';
import { Provider, connect } from 'react-redux';
import { Route, Switch, Link, Redirect, BrowserRouter } from 'react-router-dom';

class Entry extends React.Component {
    render() {
        return (
            <Provider store={store}>
                <ConnectedMain />
            </Provider>
        );
    }
}

class Main extends React.Component {
    constructor(props) {
        super(props);
    }
    render() {
        return (<div></div>);
    }
}

function mapStateToProps(state) {
    return {
        user: state.users.current
    };
}
const ConnectedMain = connect(mapStateToProps)(Main);

ReactDOM.render(<App />, document.getElementById('app'));

try {
    module.hot.accept();
} catch (ex) { }