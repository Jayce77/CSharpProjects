﻿//var data = [
//    { id: 1, author: "Daniel Lo Nigro", text: "Hello ReactJS.NET World!" },
//    { id: 2, author: "Pete Hunt", text: "This is one comment" },
//    { id: 3, author: "Jordan Walke", text: "This is *another* comment" }
//];

var CommentForm = React.createClass({
    getInitialState: function() {
        return { author: '', text: '' };
    },
    handleAuthorChange: function(e) {
        this.setState({ author: e.target.value });
    },
    handleTextChange: function(e) {
        this.setState({ text: e.target.value });
    },
    handleSubmit: function(e) {
        e.preventDefault();
        var author = this.state.author.trim();
        var text = this.state.text.trim();
        if (!text || !author) {
            return;
        }
        //TODO: send request to the server
        this.setState({ author: "", text: "" });
    },
    render: function() {
        return (
            <form className="commentForm" onSubmit={this.handleSubmit}>
                <input type="text" placeholder="Your name" value={this.state.author} onChange={this.handleAuthorChange} />
                <input type="text" placeholder="Say something..." value={this.state.text} onChange={this.handleTextChange} />
                <input type="submit" value="Post" />     
            </form>
        );
    }
});

var Comment = React.createClass({
    rawMarkup: function () {
        var md = new Remarkable();
        var rawMarkup = md.render(this.props.children.toString());
        return { __html: rawMarkup };
    },

    render: function () {
        return (
            <div className="comment">
                <h2 className="commentAuthor">
                    {this.props.author}
                </h2>
                <span dangerouslySetInnerHTML={this.rawMarkup()} />
            </div>
        );
    }
});

var CommentList = React.createClass({
    render: function () {
        var commentNodes = this.props.data.map(function (comment) {
            return (
                <div className="commentList" >
                    <Comment author={ comment.author } key={ comment.id }>
                        { comment.text }
                    </Comment>
                </div>
            );
        });
        return (
            <div className="commentList" >
                { commentNodes }
            </div>
        );
    }
});

var CommentForm = React.createClass({
    render: function () {
        return (
            <div className="commentForm">
                Comment form here
            </div>
        );
    }
});

var CommentBox = React.createClass({
    loadCommentsFromServer: function () {
        var xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        }.bind(this);
        xhr.send();
    },
    getInitialState: function () {
        return { data: [] };
    },
    componentDidMount: function () {
        this.loadCommentsFromServer();
        window.setInterval(this.loadCommentsFromServer, this.props.pollInterval);
    },
    render: function () {
        return (
            <div className="commentBox">
                <h1>Comments</h1>
                <CommentList data={this.state.data} />
                <CommentForm />
            </div>
        );
    }
});

ReactDOM.render(
    <CommentBox url="/comments" pollInterval={2000} />,
    document.getElementById('content')
);